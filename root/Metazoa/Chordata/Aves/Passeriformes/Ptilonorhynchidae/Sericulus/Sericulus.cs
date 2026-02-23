using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae.Sericulus;

/// <summary>
/// Abstract class for Sericulus (genus).
/// NCBI TaxId: 34936
/// </summary>
public abstract class Sericulus : Ptilonorhynchidae, ISericulus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sericulus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34936;

    /// <inheritdoc />
    public virtual string GenusName => "Sericulus";

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
