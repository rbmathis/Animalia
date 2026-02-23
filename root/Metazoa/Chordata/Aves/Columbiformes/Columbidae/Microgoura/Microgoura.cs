using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Microgoura;

/// <summary>
/// Abstract class for Microgoura (genus).
/// NCBI TaxId: 2953412
/// </summary>
public abstract class Microgoura : Columbidae, IMicrogoura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Microgoura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2953412;

    /// <inheritdoc />
    public virtual string GenusName => "Microgoura";

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
