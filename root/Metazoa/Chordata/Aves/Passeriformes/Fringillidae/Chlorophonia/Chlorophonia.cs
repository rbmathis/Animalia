using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Chlorophonia;

/// <summary>
/// Abstract class for Chlorophonia (genus).
/// NCBI TaxId: 62166
/// </summary>
public abstract class Chlorophonia : Fringillidae, IChlorophonia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlorophonia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62166;

    /// <inheritdoc />
    public virtual string GenusName => "Chlorophonia";

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
