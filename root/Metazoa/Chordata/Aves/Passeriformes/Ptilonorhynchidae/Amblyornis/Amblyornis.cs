using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae.Amblyornis;

/// <summary>
/// Abstract class for Amblyornis (genus).
/// NCBI TaxId: 9165
/// </summary>
public abstract class Amblyornis : Ptilonorhynchidae, IAmblyornis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Amblyornis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 9165;

    /// <inheritdoc />
    public virtual string GenusName => "Amblyornis";

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
