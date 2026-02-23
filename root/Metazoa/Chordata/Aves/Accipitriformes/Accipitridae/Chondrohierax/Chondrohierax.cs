using AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Accipitriformes.Accipitridae.Chondrohierax;

/// <summary>
/// Abstract class for Chondrohierax (genus).
/// NCBI TaxId: 321077
/// </summary>
public abstract class Chondrohierax : Accipitridae, IChondrohierax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chondrohierax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 321077;

    /// <inheritdoc />
    public virtual string GenusName => "Chondrohierax";

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
