using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Spalacidae.Myospalax;

/// <summary>
/// Abstract class for Myospalax (genus).
/// NCBI TaxId: 106349
/// </summary>
public abstract class Myospalax : Spalacidae, IMyospalax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Myospalax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 106349;

    /// <inheritdoc />
    public virtual string GenusName => "Myospalax";

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
