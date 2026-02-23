using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Phylloscopidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Phylloscopidae.Seicercus;

/// <summary>
/// Abstract class for Seicercus (genus).
/// NCBI TaxId: 90657
/// </summary>
public abstract class Seicercus : Phylloscopidae, ISeicercus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Seicercus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 90657;

    /// <inheritdoc />
    public virtual string GenusName => "Seicercus";

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
