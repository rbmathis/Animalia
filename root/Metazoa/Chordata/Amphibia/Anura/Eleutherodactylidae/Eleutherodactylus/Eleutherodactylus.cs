using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Eleutherodactylidae.Eleutherodactylus;

/// <summary>
/// Abstract class for Eleutherodactylus (genus).
/// NCBI TaxId: 8380
/// </summary>
public abstract class Eleutherodactylus : Eleutherodactylidae, IEleutherodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eleutherodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8380;

    /// <inheritdoc />
    public virtual string GenusName => "Eleutherodactylus";

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
