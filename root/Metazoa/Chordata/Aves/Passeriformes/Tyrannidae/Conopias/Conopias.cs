using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Conopias;

/// <summary>
/// Abstract class for Conopias (genus).
/// NCBI TaxId: 1118528
/// </summary>
public abstract class Conopias : Tyrannidae, IConopias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Conopias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1118528;

    /// <inheritdoc />
    public virtual string GenusName => "Conopias";

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
