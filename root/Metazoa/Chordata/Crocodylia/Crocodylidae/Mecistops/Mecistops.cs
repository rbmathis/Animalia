using AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Crocodylia.Crocodylidae.Mecistops;

/// <summary>
/// Abstract class for Mecistops (genus).
/// NCBI TaxId: 423492
/// </summary>
public abstract class Mecistops : Crocodylidae, IMecistops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Mecistops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 423492;

    /// <inheritdoc />
    public virtual string GenusName => "Mecistops";

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
