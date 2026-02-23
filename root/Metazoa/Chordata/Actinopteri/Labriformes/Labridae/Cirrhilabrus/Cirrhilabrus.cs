using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Cirrhilabrus;

/// <summary>
/// Abstract class for Cirrhilabrus (genus).
/// NCBI TaxId: 241276
/// </summary>
public abstract class Cirrhilabrus : Labridae, ICirrhilabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cirrhilabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241276;

    /// <inheritdoc />
    public virtual string GenusName => "Cirrhilabrus";

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
