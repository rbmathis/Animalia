using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Picathartidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Picathartidae.Chaetops;

/// <summary>
/// Abstract class for Chaetops (genus).
/// NCBI TaxId: 221965
/// </summary>
public abstract class Chaetops : Picathartidae, IChaetops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chaetops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 221965;

    /// <inheritdoc />
    public virtual string GenusName => "Chaetops";

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
