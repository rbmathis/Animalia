using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Etmopteridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Squaliformes.Etmopteridae.Centroscyllium;

/// <summary>
/// Abstract class for Centroscyllium (genus).
/// NCBI TaxId: 170812
/// </summary>
public abstract class Centroscyllium : Etmopteridae, ICentroscyllium
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Centroscyllium";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 170812;

    /// <inheritdoc />
    public virtual string GenusName => "Centroscyllium";

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
