using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anhimidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anhimidae.Chauna;

/// <summary>
/// Abstract class for Chauna (genus).
/// NCBI TaxId: 8828
/// </summary>
public abstract class Chauna : Anhimidae, IChauna
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chauna";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8828;

    /// <inheritdoc />
    public virtual string GenusName => "Chauna";

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
