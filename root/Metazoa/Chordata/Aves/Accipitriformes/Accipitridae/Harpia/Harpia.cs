using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Harpia;

/// <summary>
/// Abstract class for Harpia (genus).
/// NCBI TaxId: 202279
/// </summary>
public abstract class Harpia : Accipitridae, IHarpia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Harpia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 202279;

    /// <inheritdoc />
    public virtual string GenusName => "Harpia";

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
