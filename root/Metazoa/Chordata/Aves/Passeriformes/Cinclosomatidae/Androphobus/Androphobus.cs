using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclosomatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Cinclosomatidae.Androphobus;

/// <summary>
/// Abstract class for Androphobus (genus).
/// NCBI TaxId: 461240
/// </summary>
public abstract class Androphobus : Cinclosomatidae, IAndrophobus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Androphobus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 461240;

    /// <inheritdoc />
    public virtual string GenusName => "Androphobus";

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
