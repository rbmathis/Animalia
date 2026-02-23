using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae.Prionodura;

/// <summary>
/// Abstract class for Prionodura (genus).
/// NCBI TaxId: 34934
/// </summary>
public abstract class Prionodura : Ptilonorhynchidae, IPrionodura
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Prionodura";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34934;

    /// <inheritdoc />
    public virtual string GenusName => "Prionodura";

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
