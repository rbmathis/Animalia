using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cichliformes.Cichlidae.Tomocichla;

/// <summary>
/// Abstract class for Tomocichla (genus).
/// NCBI TaxId: 63182
/// </summary>
public abstract class Tomocichla : Cichlidae, ITomocichla
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Tomocichla";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 63182;

    /// <inheritdoc />
    public virtual string GenusName => "Tomocichla";

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
