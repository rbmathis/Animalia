using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.Tripterygiidae.Springerichthys;

/// <summary>
/// Abstract class for Springerichthys (genus).
/// NCBI TaxId: 2012960
/// </summary>
public abstract class Springerichthys : Tripterygiidae, ISpringerichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Springerichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2012960;

    /// <inheritdoc />
    public virtual string GenusName => "Springerichthys";

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
