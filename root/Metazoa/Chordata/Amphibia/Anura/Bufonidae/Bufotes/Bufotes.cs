using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Bufonidae.Bufotes;

/// <summary>
/// Abstract class for Bufotes (genus).
/// NCBI TaxId: 651673
/// </summary>
public abstract class Bufotes : Bufonidae, IBufotes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Bufotes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 651673;

    /// <inheritdoc />
    public virtual string GenusName => "Bufotes";

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
