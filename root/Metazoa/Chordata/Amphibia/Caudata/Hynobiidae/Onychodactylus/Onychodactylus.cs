using AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Hynobiidae.Onychodactylus;

/// <summary>
/// Abstract class for Onychodactylus (genus).
/// NCBI TaxId: 113381
/// </summary>
public abstract class Onychodactylus : Hynobiidae, IOnychodactylus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Onychodactylus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 113381;

    /// <inheritdoc />
    public virtual string GenusName => "Onychodactylus";

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
