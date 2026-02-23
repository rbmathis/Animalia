using AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Cuculiformes.Cuculidae.Eudynamys;

/// <summary>
/// Abstract class for Eudynamys (genus).
/// NCBI TaxId: 8944
/// </summary>
public abstract class Eudynamys : Cuculidae, IEudynamys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Eudynamys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 8944;

    /// <inheritdoc />
    public virtual string GenusName => "Eudynamys";

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
