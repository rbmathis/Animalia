using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Teiidae.Aspidoscelis;

/// <summary>
/// Abstract class for Aspidoscelis (genus).
/// NCBI TaxId: 212526
/// </summary>
public abstract class Aspidoscelis : Teiidae, IAspidoscelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aspidoscelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 212526;

    /// <inheritdoc />
    public virtual string GenusName => "Aspidoscelis";

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
