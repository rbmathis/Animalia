using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Anostomidae.Sartor;

/// <summary>
/// Abstract class for Sartor (genus).
/// NCBI TaxId: 2499844
/// </summary>
public abstract class Sartor : Anostomidae, ISartor
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Sartor";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2499844;

    /// <inheritdoc />
    public virtual string GenusName => "Sartor";

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
