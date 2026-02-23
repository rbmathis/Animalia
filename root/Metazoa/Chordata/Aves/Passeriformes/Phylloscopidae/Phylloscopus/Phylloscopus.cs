using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Phylloscopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Phylloscopidae.Phylloscopus;

/// <summary>
/// Abstract class for Phylloscopus (genus).
/// NCBI TaxId: 9181
/// </summary>
public abstract class Phylloscopus : Phylloscopidae, IPhylloscopus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Phylloscopus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9181;

    /// <inheritdoc />
    public virtual string GenusName => "Phylloscopus";

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
