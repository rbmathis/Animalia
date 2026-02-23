using AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Lacertidae.Acanthodactylus;

/// <summary>
/// Abstract class for Acanthodactylus (genus).
/// NCBI TaxId: 80443
/// </summary>
public abstract class Acanthodactylus : Lacertidae, IAcanthodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Acanthodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 80443;

    /// <inheritdoc />
    public virtual string GenusName => "Acanthodactylus";

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
