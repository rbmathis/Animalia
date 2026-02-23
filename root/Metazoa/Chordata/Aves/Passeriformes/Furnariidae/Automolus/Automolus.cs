using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Furnariidae.Automolus;

/// <summary>
/// Abstract class for Automolus (genus).
/// NCBI TaxId: 190677
/// </summary>
public abstract class Automolus : Furnariidae, IAutomolus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Automolus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 190677;

    /// <inheritdoc />
    public virtual string GenusName => "Automolus";

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
