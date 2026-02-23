using AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Megapodiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Galliformes.Megapodiidae.Aepypodius;

/// <summary>
/// Abstract class for Aepypodius (genus).
/// NCBI TaxId: 30400
/// </summary>
public abstract class Aepypodius : Megapodiidae, IAepypodius
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Aepypodius";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 30400;

    /// <inheritdoc />
    public virtual string GenusName => "Aepypodius";

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
