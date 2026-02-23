using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Leptopterus;

/// <summary>
/// Abstract class for Leptopterus (genus).
/// NCBI TaxId: 125298
/// </summary>
public abstract class Leptopterus : Vangidae, ILeptopterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Leptopterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 125298;

    /// <inheritdoc />
    public virtual string GenusName => "Leptopterus";

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
