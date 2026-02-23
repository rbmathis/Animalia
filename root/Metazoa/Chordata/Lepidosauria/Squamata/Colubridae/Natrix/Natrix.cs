using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Colubridae.Natrix;

/// <summary>
/// Abstract class for Natrix (genus).
/// NCBI TaxId: 8583
/// </summary>
public abstract class Natrix : Colubridae, INatrix
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Natrix";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8583;

    /// <inheritdoc />
    public virtual string GenusName => "Natrix";

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
