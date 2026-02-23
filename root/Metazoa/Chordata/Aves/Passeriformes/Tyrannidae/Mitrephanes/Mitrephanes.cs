using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Mitrephanes;

/// <summary>
/// Abstract class for Mitrephanes (genus).
/// NCBI TaxId: 183542
/// </summary>
public abstract class Mitrephanes : Tyrannidae, IMitrephanes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mitrephanes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183542;

    /// <inheritdoc />
    public virtual string GenusName => "Mitrephanes";

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
