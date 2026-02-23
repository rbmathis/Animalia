using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Estrildidae.Spermestes;

/// <summary>
/// Abstract class for Spermestes (genus).
/// NCBI TaxId: 2715631
/// </summary>
public abstract class Spermestes : Estrildidae, ISpermestes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Spermestes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2715631;

    /// <inheritdoc />
    public virtual string GenusName => "Spermestes";

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
