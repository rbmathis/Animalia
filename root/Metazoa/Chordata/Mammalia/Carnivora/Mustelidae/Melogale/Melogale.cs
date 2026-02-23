using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Carnivora.Mustelidae.Melogale;

/// <summary>
/// Abstract class for Melogale (genus).
/// NCBI TaxId: 204266
/// </summary>
public abstract class Melogale : Mustelidae, IMelogale
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melogale";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 204266;

    /// <inheritdoc />
    public virtual string GenusName => "Melogale";

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
