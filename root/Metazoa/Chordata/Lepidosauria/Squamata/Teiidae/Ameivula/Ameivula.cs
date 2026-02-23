using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Ameivula;

/// <summary>
/// Abstract class for Ameivula (genus).
/// NCBI TaxId: 1392238
/// </summary>
public abstract class Ameivula : Teiidae, IAmeivula
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ameivula";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1392238;

    /// <inheritdoc />
    public virtual string GenusName => "Ameivula";

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
