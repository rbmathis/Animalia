using AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Charadriiformes.Alcidae.Aethia;

/// <summary>
/// Abstract class for Aethia (genus).
/// NCBI TaxId: 28684
/// </summary>
public abstract class Aethia : Alcidae, IAethia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aethia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 28684;

    /// <inheritdoc />
    public virtual string GenusName => "Aethia";

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
