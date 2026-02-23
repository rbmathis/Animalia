using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Phylloscartes;

/// <summary>
/// Abstract class for Phylloscartes (genus).
/// NCBI TaxId: 456418
/// </summary>
public abstract class Phylloscartes : Tyrannidae, IPhylloscartes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phylloscartes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 456418;

    /// <inheritdoc />
    public virtual string GenusName => "Phylloscartes";

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
