using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.Virididentex;

/// <summary>
/// Abstract class for Virididentex (genus).
/// NCBI TaxId: 490344
/// </summary>
public abstract class Virididentex : Sparidae, IVirididentex
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Virididentex";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 490344;

    /// <inheritdoc />
    public virtual string GenusName => "Virididentex";

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
