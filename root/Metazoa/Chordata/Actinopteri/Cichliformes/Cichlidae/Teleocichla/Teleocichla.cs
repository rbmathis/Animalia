using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Teleocichla;

/// <summary>
/// Abstract class for Teleocichla (genus).
/// NCBI TaxId: 74134
/// </summary>
public abstract class Teleocichla : Cichlidae, ITeleocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Teleocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 74134;

    /// <inheritdoc />
    public virtual string GenusName => "Teleocichla";

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
