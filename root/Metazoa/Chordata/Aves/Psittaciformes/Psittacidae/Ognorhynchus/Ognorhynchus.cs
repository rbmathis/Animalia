using AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Psittaciformes.Psittacidae.Ognorhynchus;

/// <summary>
/// Abstract class for Ognorhynchus (genus).
/// NCBI TaxId: 2282774
/// </summary>
public abstract class Ognorhynchus : Psittacidae, IOgnorhynchus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Ognorhynchus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2282774;

    /// <inheritdoc />
    public virtual string GenusName => "Ognorhynchus";

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
