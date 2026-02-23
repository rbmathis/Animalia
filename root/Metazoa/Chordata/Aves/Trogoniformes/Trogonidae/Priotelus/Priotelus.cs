using AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Trogoniformes.Trogonidae.Priotelus;

/// <summary>
/// Abstract class for Priotelus (genus).
/// NCBI TaxId: 57431
/// </summary>
public abstract class Priotelus : Trogonidae, IPriotelus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Priotelus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57431;

    /// <inheritdoc />
    public virtual string GenusName => "Priotelus";

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
