using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Iranocichla;

/// <summary>
/// Abstract class for Iranocichla (genus).
/// NCBI TaxId: 158764
/// </summary>
public abstract class Iranocichla : Cichlidae, IIranocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Iranocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 158764;

    /// <inheritdoc />
    public virtual string GenusName => "Iranocichla";

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
