using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Thraupidae.Creurgops;

/// <summary>
/// Abstract class for Creurgops (genus).
/// NCBI TaxId: 62182
/// </summary>
public abstract class Creurgops : Thraupidae, ICreurgops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Creurgops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 62182;

    /// <inheritdoc />
    public virtual string GenusName => "Creurgops";

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
