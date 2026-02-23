using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Clinidae.Springeratus;

/// <summary>
/// Abstract class for Springeratus (genus).
/// NCBI TaxId: 1916801
/// </summary>
public abstract class Springeratus : Clinidae, ISpringeratus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Springeratus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1916801;

    /// <inheritdoc />
    public virtual string GenusName => "Springeratus";

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
