using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Pictilabrus;

/// <summary>
/// Abstract class for Pictilabrus (genus).
/// NCBI TaxId: 241332
/// </summary>
public abstract class Pictilabrus : Labridae, IPictilabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Pictilabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 241332;

    /// <inheritdoc />
    public virtual string GenusName => "Pictilabrus";

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
