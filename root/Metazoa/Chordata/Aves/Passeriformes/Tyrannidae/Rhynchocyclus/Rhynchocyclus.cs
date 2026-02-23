using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Rhynchocyclus;

/// <summary>
/// Abstract class for Rhynchocyclus (genus).
/// NCBI TaxId: 360247
/// </summary>
public abstract class Rhynchocyclus : Tyrannidae, IRhynchocyclus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Rhynchocyclus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 360247;

    /// <inheritdoc />
    public virtual string GenusName => "Rhynchocyclus";

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
