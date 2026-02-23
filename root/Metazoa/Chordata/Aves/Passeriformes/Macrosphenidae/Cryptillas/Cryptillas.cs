using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Macrosphenidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Macrosphenidae.Cryptillas;

/// <summary>
/// Abstract class for Cryptillas (genus).
/// NCBI TaxId: 3151088
/// </summary>
public abstract class Cryptillas : Macrosphenidae, ICryptillas
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Cryptillas";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3151088;

    /// <inheritdoc />
    public virtual string GenusName => "Cryptillas";

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
