using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Elagatis;

/// <summary>
/// Abstract class for Elagatis (genus).
/// NCBI TaxId: 173323
/// </summary>
public abstract class Elagatis : Carangidae, IElagatis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Elagatis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 173323;

    /// <inheritdoc />
    public virtual string GenusName => "Elagatis";

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
