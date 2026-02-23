using AnimalKingdom.root.Metazoa.Chordata.Testudines.Carettochelyidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Carettochelyidae.Carettochelys;

/// <summary>
/// Abstract class for Carettochelys (genus).
/// NCBI TaxId: 44488
/// </summary>
public abstract class Carettochelys : Carettochelyidae, ICarettochelys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "Carettochelys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "genus";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 44488;

    /// <inheritdoc />
    public virtual string GenusName => "Carettochelys";

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
