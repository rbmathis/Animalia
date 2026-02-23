using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Euodice;

/// <summary>
/// Abstract class for Euodice (genus).
/// NCBI TaxId: 2817152
/// </summary>
public abstract class Euodice : Estrildidae, IEuodice
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euodice";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2817152;

    /// <inheritdoc />
    public virtual string GenusName => "Euodice";

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
