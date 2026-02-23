using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Carangiformes.Carangidae.Euprepocaranx;

/// <summary>
/// Abstract class for Euprepocaranx (genus).
/// NCBI TaxId: 3049891
/// </summary>
public abstract class Euprepocaranx : Carangidae, IEuprepocaranx
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Euprepocaranx";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3049891;

    /// <inheritdoc />
    public virtual string GenusName => "Euprepocaranx";

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
