using AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Polysticta;

/// <summary>
/// Abstract class for Polysticta (genus).
/// NCBI TaxId: 234622
/// </summary>
public abstract class Polysticta : Anatidae, IPolysticta
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Polysticta";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 234622;

    /// <inheritdoc />
    public virtual string GenusName => "Polysticta";

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
