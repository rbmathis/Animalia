using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Fringillidae.Melamprosops;

/// <summary>
/// Abstract class for Melamprosops (genus).
/// NCBI TaxId: 385244
/// </summary>
public abstract class Melamprosops : Fringillidae, IMelamprosops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Melamprosops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 385244;

    /// <inheritdoc />
    public virtual string GenusName => "Melamprosops";

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
