using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Calcariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Calcariidae.Rhynchophanes;

/// <summary>
/// Abstract class for Rhynchophanes (genus).
/// NCBI TaxId: 3151086
/// </summary>
public abstract class Rhynchophanes : Calcariidae, IRhynchophanes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchophanes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3151086;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchophanes";

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
