using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Merganetta;

/// <summary>
/// Abstract class for Merganetta (genus).
/// NCBI TaxId: 658918
/// </summary>
public abstract class Merganetta : Anatidae, IMerganetta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Merganetta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 658918;

    /// <inheritdoc />
    public virtual string GenusName => "Merganetta";

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
