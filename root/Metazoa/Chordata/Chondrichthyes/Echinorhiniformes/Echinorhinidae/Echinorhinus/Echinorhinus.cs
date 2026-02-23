using AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Echinorhiniformes.Echinorhinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Echinorhiniformes.Echinorhinidae.Echinorhinus;

/// <summary>
/// Abstract class for Echinorhinus (genus).
/// NCBI TaxId: 7833
/// </summary>
public abstract class Echinorhinus : Echinorhinidae, IEchinorhinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Echinorhinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 7833;

    /// <inheritdoc />
    public virtual string GenusName => "Echinorhinus";

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
