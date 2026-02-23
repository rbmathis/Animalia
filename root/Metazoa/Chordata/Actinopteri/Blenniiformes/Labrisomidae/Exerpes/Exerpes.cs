using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Labrisomidae.Exerpes;

/// <summary>
/// Abstract class for Exerpes (genus).
/// NCBI TaxId: 57798
/// </summary>
public abstract class Exerpes : Labrisomidae, IExerpes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Exerpes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 57798;

    /// <inheritdoc />
    public virtual string GenusName => "Exerpes";

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
