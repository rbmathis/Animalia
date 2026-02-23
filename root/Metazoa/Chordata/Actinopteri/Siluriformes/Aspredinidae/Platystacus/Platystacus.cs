using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Aspredinidae.Platystacus;

/// <summary>
/// Abstract class for Platystacus (genus).
/// NCBI TaxId: 385421
/// </summary>
public abstract class Platystacus : Aspredinidae, IPlatystacus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Platystacus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 385421;

    /// <inheritdoc />
    public virtual string GenusName => "Platystacus";

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
