using AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Ptilonorhynchidae.Chlamydera;

/// <summary>
/// Abstract class for Chlamydera (genus).
/// NCBI TaxId: 34930
/// </summary>
public abstract class Chlamydera : Ptilonorhynchidae, IChlamydera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Chlamydera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 34930;

    /// <inheritdoc />
    public virtual string GenusName => "Chlamydera";

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
