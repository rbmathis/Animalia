using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Pelodryadidae.Pengilleyia;

/// <summary>
/// Abstract class for Pengilleyia (genus).
/// NCBI TaxId: 3681003
/// </summary>
public abstract class Pengilleyia : Pelodryadidae, IPengilleyia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pengilleyia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3681003;

    /// <inheritdoc />
    public virtual string GenusName => "Pengilleyia";

    /// <inheritdoc />
    public virtual string[] GenusCharacteristics => new[]
    {
        "Large body size",
        "Social pack structure",
        "Complex hunting strategies",
        "Highly developed olfaction",
        "Territorial behavior"
    };

    /// <inheritdoc />
    public virtual bool CanInterbreed => true;

}
