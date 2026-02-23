using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Melanitta;

/// <summary>
/// Abstract class for Melanitta (genus).
/// NCBI TaxId: 198026
/// </summary>
public abstract class Melanitta : Anatidae, IMelanitta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melanitta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 198026;

    /// <inheritdoc />
    public virtual string GenusName => "Melanitta";

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
