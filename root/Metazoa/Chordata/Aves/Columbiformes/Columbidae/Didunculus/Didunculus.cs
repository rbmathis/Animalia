using AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Columbiformes.Columbidae.Didunculus;

/// <summary>
/// Abstract class for Didunculus (genus).
/// NCBI TaxId: 187110
/// </summary>
public abstract class Didunculus : Columbidae, IDidunculus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Didunculus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 187110;

    /// <inheritdoc />
    public virtual string GenusName => "Didunculus";

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
