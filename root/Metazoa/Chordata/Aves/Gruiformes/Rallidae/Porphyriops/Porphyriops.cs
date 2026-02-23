using AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Gruiformes.Rallidae.Porphyriops;

/// <summary>
/// Abstract class for Porphyriops (genus).
/// NCBI TaxId: 3150827
/// </summary>
public abstract class Porphyriops : Rallidae, IPorphyriops
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Porphyriops";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3150827;

    /// <inheritdoc />
    public virtual string GenusName => "Porphyriops";

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
